using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Hierococcyx;

/// <summary>
/// Abstract class for Hierococcyx (genus).
/// NCBI TaxId: 1118539
/// </summary>
public abstract class Hierococcyx : Cuculidae, IHierococcyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hierococcyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118539;

    /// <inheritdoc />
    public virtual string GenusName => "Hierococcyx";

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
