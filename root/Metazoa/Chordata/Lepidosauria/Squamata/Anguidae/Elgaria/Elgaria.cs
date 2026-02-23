using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Elgaria;

/// <summary>
/// Abstract class for Elgaria (genus).
/// NCBI TaxId: 52221
/// </summary>
public abstract class Elgaria : Anguidae, IElgaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elgaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52221;

    /// <inheritdoc />
    public virtual string GenusName => "Elgaria";

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
