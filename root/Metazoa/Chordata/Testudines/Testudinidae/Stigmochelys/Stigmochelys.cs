using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Stigmochelys;

/// <summary>
/// Abstract class for Stigmochelys (genus).
/// NCBI TaxId: 1358125
/// </summary>
public abstract class Stigmochelys : Testudinidae, IStigmochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stigmochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1358125;

    /// <inheritdoc />
    public virtual string GenusName => "Stigmochelys";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
