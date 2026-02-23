using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gorogobius;

/// <summary>
/// Abstract class for Gorogobius (genus).
/// NCBI TaxId: 1365687
/// </summary>
public abstract class Gorogobius : Gobiidae, IGorogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gorogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365687;

    /// <inheritdoc />
    public virtual string GenusName => "Gorogobius";

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
