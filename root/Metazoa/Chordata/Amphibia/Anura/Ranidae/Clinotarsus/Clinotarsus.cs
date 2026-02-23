using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Clinotarsus;

/// <summary>
/// Abstract class for Clinotarsus (genus).
/// NCBI TaxId: 129028
/// </summary>
public abstract class Clinotarsus : Ranidae, IClinotarsus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clinotarsus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129028;

    /// <inheritdoc />
    public virtual string GenusName => "Clinotarsus";

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
