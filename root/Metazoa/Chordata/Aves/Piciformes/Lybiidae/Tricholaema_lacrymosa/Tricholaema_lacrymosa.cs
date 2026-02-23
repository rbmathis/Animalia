using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Tricholaema_lacrymosa;

/// <summary>
/// Abstract class for Tricholaema lacrymosa (genus).
/// NCBI TaxId: 240726
/// </summary>
public abstract class Tricholaema_lacrymosa : Lybiidae, ITricholaema_lacrymosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tricholaema lacrymosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240726;

    /// <inheritdoc />
    public virtual string GenusName => "Tricholaema_lacrymosa";

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
