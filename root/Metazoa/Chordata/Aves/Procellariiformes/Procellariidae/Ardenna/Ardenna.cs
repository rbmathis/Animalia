using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Ardenna;

/// <summary>
/// Abstract class for Ardenna (genus).
/// NCBI TaxId: 1934104
/// </summary>
public abstract class Ardenna : Procellariidae, IArdenna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ardenna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1934104;

    /// <inheritdoc />
    public virtual string GenusName => "Ardenna";

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
