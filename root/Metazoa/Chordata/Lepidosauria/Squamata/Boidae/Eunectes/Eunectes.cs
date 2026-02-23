using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Eunectes;

/// <summary>
/// Abstract class for Eunectes (genus).
/// NCBI TaxId: 51875
/// </summary>
public abstract class Eunectes : Boidae, IEunectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eunectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51875;

    /// <inheritdoc />
    public virtual string GenusName => "Eunectes";

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
