using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Astyanacinus;

/// <summary>
/// Abstract class for Astyanacinus (genus).
/// NCBI TaxId: 303979
/// </summary>
public abstract class Astyanacinus : Acestrorhamphidae, IAstyanacinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astyanacinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303979;

    /// <inheritdoc />
    public virtual string GenusName => "Astyanacinus";

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
