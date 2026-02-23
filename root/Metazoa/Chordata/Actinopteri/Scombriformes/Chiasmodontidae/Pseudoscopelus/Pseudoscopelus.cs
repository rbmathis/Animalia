using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.Pseudoscopelus;

/// <summary>
/// Abstract class for Pseudoscopelus (genus).
/// NCBI TaxId: 1306755
/// </summary>
public abstract class Pseudoscopelus : Chiasmodontidae, IPseudoscopelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoscopelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1306755;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoscopelus";

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
