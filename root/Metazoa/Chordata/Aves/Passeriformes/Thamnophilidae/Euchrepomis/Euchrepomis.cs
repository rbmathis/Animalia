using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Euchrepomis;

/// <summary>
/// Abstract class for Euchrepomis (genus).
/// NCBI TaxId: 2765310
/// </summary>
public abstract class Euchrepomis : Thamnophilidae, IEuchrepomis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euchrepomis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2765310;

    /// <inheritdoc />
    public virtual string GenusName => "Euchrepomis";

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
