using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Oceanites;

/// <summary>
/// Abstract class for Oceanites (genus).
/// NCBI TaxId: 79652
/// </summary>
public abstract class Oceanites : Procellariiformes, IOceanites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oceanites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 79652;

    /// <inheritdoc />
    public virtual string GenusName => "Oceanites";

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
