using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Dipsochelys;

/// <summary>
/// Abstract class for Dipsochelys (genus).
/// NCBI TaxId: 133438
/// </summary>
public abstract class Dipsochelys : Testudinidae, IDipsochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dipsochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 133438;

    /// <inheritdoc />
    public virtual string GenusName => "Dipsochelys";

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
