using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Acrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Acrobatidae.Distoechurus;

/// <summary>
/// Abstract class for Distoechurus (genus).
/// NCBI TaxId: 38613
/// </summary>
public abstract class Distoechurus : Acrobatidae, IDistoechurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Distoechurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38613;

    /// <inheritdoc />
    public virtual string GenusName => "Distoechurus";

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
