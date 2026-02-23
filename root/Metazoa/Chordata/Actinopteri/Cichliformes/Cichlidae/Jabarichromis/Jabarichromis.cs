using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Jabarichromis;

/// <summary>
/// Abstract class for Jabarichromis (genus).
/// NCBI TaxId: 3363427
/// </summary>
public abstract class Jabarichromis : Cichlidae, IJabarichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jabarichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363427;

    /// <inheritdoc />
    public virtual string GenusName => "Jabarichromis";

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
