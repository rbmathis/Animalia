using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Pseudomystus;

/// <summary>
/// Abstract class for Pseudomystus (genus).
/// NCBI TaxId: 337636
/// </summary>
public abstract class Pseudomystus : Bagridae, IPseudomystus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudomystus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337636;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudomystus";

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
