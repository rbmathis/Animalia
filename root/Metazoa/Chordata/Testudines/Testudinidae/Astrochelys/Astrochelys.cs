using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Astrochelys;

/// <summary>
/// Abstract class for Astrochelys (genus).
/// NCBI TaxId: 532072
/// </summary>
public abstract class Astrochelys : Testudinidae, IAstrochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astrochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 532072;

    /// <inheritdoc />
    public virtual string GenusName => "Astrochelys";

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
