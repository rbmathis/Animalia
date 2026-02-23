using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Ferrarissoaresia;

/// <summary>
/// Abstract class for Ferrarissoaresia (genus).
/// NCBI TaxId: 2613932
/// </summary>
public abstract class Ferrarissoaresia : Auchenipteridae, IFerrarissoaresia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ferrarissoaresia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2613932;

    /// <inheritdoc />
    public virtual string GenusName => "Ferrarissoaresia";

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
