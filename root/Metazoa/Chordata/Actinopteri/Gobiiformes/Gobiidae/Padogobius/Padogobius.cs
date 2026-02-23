using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Padogobius;

/// <summary>
/// Abstract class for Padogobius (genus).
/// NCBI TaxId: 85423
/// </summary>
public abstract class Padogobius : Gobiidae, IPadogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Padogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 85423;

    /// <inheritdoc />
    public virtual string GenusName => "Padogobius";

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
