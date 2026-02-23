using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Gladioglanis;

/// <summary>
/// Abstract class for Gladioglanis (genus).
/// NCBI TaxId: 1281317
/// </summary>
public abstract class Gladioglanis : Heptapteridae, IGladioglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gladioglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1281317;

    /// <inheritdoc />
    public virtual string GenusName => "Gladioglanis";

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
