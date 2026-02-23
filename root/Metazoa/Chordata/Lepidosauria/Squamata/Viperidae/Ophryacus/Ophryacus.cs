using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Ophryacus;

/// <summary>
/// Abstract class for Ophryacus (genus).
/// NCBI TaxId: 88089
/// </summary>
public abstract class Ophryacus : Viperidae, IOphryacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophryacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88089;

    /// <inheritdoc />
    public virtual string GenusName => "Ophryacus";

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
