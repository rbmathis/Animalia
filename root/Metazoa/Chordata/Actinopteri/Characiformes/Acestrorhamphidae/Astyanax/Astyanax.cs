using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Astyanax;

/// <summary>
/// Abstract class for Astyanax (genus).
/// NCBI TaxId: 7993
/// </summary>
public abstract class Astyanax : Acestrorhamphidae, IAstyanax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astyanax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7993;

    /// <inheritdoc />
    public virtual string GenusName => "Astyanax";

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
