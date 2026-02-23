using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Coptodon;

/// <summary>
/// Abstract class for Coptodon (genus).
/// NCBI TaxId: 1315722
/// </summary>
public abstract class Coptodon : Cichlidae, ICoptodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coptodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1315722;

    /// <inheritdoc />
    public virtual string GenusName => "Coptodon";

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
