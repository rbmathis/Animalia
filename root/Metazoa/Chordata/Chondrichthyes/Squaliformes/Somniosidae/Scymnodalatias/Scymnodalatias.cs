using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae.Scymnodalatias;

/// <summary>
/// Abstract class for Scymnodalatias (genus).
/// NCBI TaxId: 2980681
/// </summary>
public abstract class Scymnodalatias : Somniosidae, IScymnodalatias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scymnodalatias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2980681;

    /// <inheritdoc />
    public virtual string GenusName => "Scymnodalatias";

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
