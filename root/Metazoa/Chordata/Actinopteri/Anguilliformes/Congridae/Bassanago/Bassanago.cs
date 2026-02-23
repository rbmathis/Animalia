using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Bassanago;

/// <summary>
/// Abstract class for Bassanago (genus).
/// NCBI TaxId: 458553
/// </summary>
public abstract class Bassanago : Congridae, IBassanago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bassanago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458553;

    /// <inheritdoc />
    public virtual string GenusName => "Bassanago";

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
