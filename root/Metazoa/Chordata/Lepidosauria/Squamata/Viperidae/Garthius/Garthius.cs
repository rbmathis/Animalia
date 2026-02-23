using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Garthius;

/// <summary>
/// Abstract class for Garthius (genus).
/// NCBI TaxId: 344001
/// </summary>
public abstract class Garthius : Viperidae, IGarthius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Garthius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 344001;

    /// <inheritdoc />
    public virtual string GenusName => "Garthius";

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
