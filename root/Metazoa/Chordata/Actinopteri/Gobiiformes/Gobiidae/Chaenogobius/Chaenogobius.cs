using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Chaenogobius;

/// <summary>
/// Abstract class for Chaenogobius (genus).
/// NCBI TaxId: 166740
/// </summary>
public abstract class Chaenogobius : Gobiidae, IChaenogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaenogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166740;

    /// <inheritdoc />
    public virtual string GenusName => "Chaenogobius";

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
