using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Ctenopharyngodon;

/// <summary>
/// Abstract class for Ctenopharyngodon (genus).
/// NCBI TaxId: 7958
/// </summary>
public abstract class Ctenopharyngodon : Xenocyprididae, ICtenopharyngodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenopharyngodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7958;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenopharyngodon";

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
