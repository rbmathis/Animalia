using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Hispidoberycidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Hispidoberycidae.Hispidoberyx;

/// <summary>
/// Abstract class for Hispidoberyx (genus).
/// NCBI TaxId: 3362378
/// </summary>
public abstract class Hispidoberyx : Hispidoberycidae, IHispidoberyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hispidoberyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362378;

    /// <inheritdoc />
    public virtual string GenusName => "Hispidoberyx";

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
