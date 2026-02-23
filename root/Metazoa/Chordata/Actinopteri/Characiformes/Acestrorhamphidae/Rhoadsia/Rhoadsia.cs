using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Rhoadsia;

/// <summary>
/// Abstract class for Rhoadsia (genus).
/// NCBI TaxId: 1445602
/// </summary>
public abstract class Rhoadsia : Acestrorhamphidae, IRhoadsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhoadsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1445602;

    /// <inheritdoc />
    public virtual string GenusName => "Rhoadsia";

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
