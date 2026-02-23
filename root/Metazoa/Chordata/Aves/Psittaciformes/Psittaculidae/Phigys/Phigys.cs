using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Phigys;

/// <summary>
/// Abstract class for Phigys (genus).
/// NCBI TaxId: 504066
/// </summary>
public abstract class Phigys : Psittaculidae, IPhigys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phigys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 504066;

    /// <inheritdoc />
    public virtual string GenusName => "Phigys";

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
