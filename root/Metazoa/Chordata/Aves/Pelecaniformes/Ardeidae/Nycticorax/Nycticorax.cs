using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Nycticorax;

/// <summary>
/// Abstract class for Nycticorax (genus).
/// NCBI TaxId: 8900
/// </summary>
public abstract class Nycticorax : Ardeidae, INycticorax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nycticorax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8900;

    /// <inheritdoc />
    public virtual string GenusName => "Nycticorax";

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
