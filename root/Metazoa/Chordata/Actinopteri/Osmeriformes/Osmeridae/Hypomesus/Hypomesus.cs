using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae.Hypomesus;

/// <summary>
/// Abstract class for Hypomesus (genus).
/// NCBI TaxId: 137519
/// </summary>
public abstract class Hypomesus : Osmeridae, IHypomesus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypomesus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137519;

    /// <inheritdoc />
    public virtual string GenusName => "Hypomesus";

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
