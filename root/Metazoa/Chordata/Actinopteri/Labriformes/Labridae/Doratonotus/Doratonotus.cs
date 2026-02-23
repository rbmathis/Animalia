using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Doratonotus;

/// <summary>
/// Abstract class for Doratonotus (genus).
/// NCBI TaxId: 700791
/// </summary>
public abstract class Doratonotus : Labridae, IDoratonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Doratonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 700791;

    /// <inheritdoc />
    public virtual string GenusName => "Doratonotus";

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
