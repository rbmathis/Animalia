using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae.Somniosus;

/// <summary>
/// Abstract class for Somniosus (genus).
/// NCBI TaxId: 191812
/// </summary>
public abstract class Somniosus : Somniosidae, ISomniosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Somniosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 191812;

    /// <inheritdoc />
    public virtual string GenusName => "Somniosus";

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
