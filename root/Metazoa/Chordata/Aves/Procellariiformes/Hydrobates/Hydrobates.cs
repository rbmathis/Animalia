using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Hydrobates;

/// <summary>
/// Abstract class for Hydrobates (genus).
/// NCBI TaxId: 79650
/// </summary>
public abstract class Hydrobates : Procellariiformes, IHydrobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 79650;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrobates";

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
