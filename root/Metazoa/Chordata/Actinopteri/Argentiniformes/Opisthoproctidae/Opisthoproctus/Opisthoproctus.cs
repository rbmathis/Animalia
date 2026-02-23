using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Opisthoproctus;

/// <summary>
/// Abstract class for Opisthoproctus (genus).
/// NCBI TaxId: 170205
/// </summary>
public abstract class Opisthoproctus : Opisthoproctidae, IOpisthoproctus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opisthoproctus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170205;

    /// <inheritdoc />
    public virtual string GenusName => "Opisthoproctus";

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
