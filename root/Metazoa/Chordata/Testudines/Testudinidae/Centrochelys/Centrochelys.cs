using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Centrochelys;

/// <summary>
/// Abstract class for Centrochelys (genus).
/// NCBI TaxId: 1540821
/// </summary>
public abstract class Centrochelys : Testudinidae, ICentrochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1540821;

    /// <inheritdoc />
    public virtual string GenusName => "Centrochelys";

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
