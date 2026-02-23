using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Chalcopsitta;

/// <summary>
/// Abstract class for Chalcopsitta (genus).
/// NCBI TaxId: 176061
/// </summary>
public abstract class Chalcopsitta : Psittaculidae, IChalcopsitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalcopsitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176061;

    /// <inheritdoc />
    public virtual string GenusName => "Chalcopsitta";

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
