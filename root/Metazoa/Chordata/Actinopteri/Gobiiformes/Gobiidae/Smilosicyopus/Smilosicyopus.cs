using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Smilosicyopus;

/// <summary>
/// Abstract class for Smilosicyopus (genus).
/// NCBI TaxId: 1407131
/// </summary>
public abstract class Smilosicyopus : Gobiidae, ISmilosicyopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Smilosicyopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1407131;

    /// <inheritdoc />
    public virtual string GenusName => "Smilosicyopus";

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
