using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Eospalax;

/// <summary>
/// Abstract class for Eospalax (genus).
/// NCBI TaxId: 146131
/// </summary>
public abstract class Eospalax : Spalacidae, IEospalax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eospalax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 146131;

    /// <inheritdoc />
    public virtual string GenusName => "Eospalax";

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
