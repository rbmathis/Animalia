using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Anthracoceros;

/// <summary>
/// Abstract class for Anthracoceros (genus).
/// NCBI TaxId: 57394
/// </summary>
public abstract class Anthracoceros : Bucerotidae, IAnthracoceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anthracoceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57394;

    /// <inheritdoc />
    public virtual string GenusName => "Anthracoceros";

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
