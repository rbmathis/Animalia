using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Aldabrachelys;

/// <summary>
/// Abstract class for Aldabrachelys (genus).
/// NCBI TaxId: 167803
/// </summary>
public abstract class Aldabrachelys : Testudinidae, IAldabrachelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aldabrachelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 167803;

    /// <inheritdoc />
    public virtual string GenusName => "Aldabrachelys";

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
