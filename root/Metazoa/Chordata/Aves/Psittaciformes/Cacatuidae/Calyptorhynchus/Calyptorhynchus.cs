using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Calyptorhynchus;

/// <summary>
/// Abstract class for Calyptorhynchus (genus).
/// NCBI TaxId: 35550
/// </summary>
public abstract class Calyptorhynchus : Cacatuidae, ICalyptorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calyptorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 35550;

    /// <inheritdoc />
    public virtual string GenusName => "Calyptorhynchus";

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
