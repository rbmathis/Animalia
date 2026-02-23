using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Paranibea;

/// <summary>
/// Abstract class for Paranibea (genus).
/// NCBI TaxId: 3362514
/// </summary>
public abstract class Paranibea : Sciaenidae, IParanibea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paranibea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362514;

    /// <inheritdoc />
    public virtual string GenusName => "Paranibea";

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
