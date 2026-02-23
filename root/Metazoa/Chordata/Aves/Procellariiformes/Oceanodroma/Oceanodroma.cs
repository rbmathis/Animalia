using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Oceanodroma;

/// <summary>
/// Abstract class for Oceanodroma (genus).
/// NCBI TaxId: 52123
/// </summary>
public abstract class Oceanodroma : Procellariiformes, IOceanodroma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oceanodroma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52123;

    /// <inheritdoc />
    public virtual string GenusName => "Oceanodroma";

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
