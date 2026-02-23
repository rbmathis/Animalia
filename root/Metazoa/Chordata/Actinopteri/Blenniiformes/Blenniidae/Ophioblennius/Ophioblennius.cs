using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Ophioblennius;

/// <summary>
/// Abstract class for Ophioblennius (genus).
/// NCBI TaxId: 57840
/// </summary>
public abstract class Ophioblennius : Blenniidae, IOphioblennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophioblennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57840;

    /// <inheritdoc />
    public virtual string GenusName => "Ophioblennius";

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
