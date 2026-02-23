using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae.Centroscymnus;

/// <summary>
/// Abstract class for Centroscymnus (genus).
/// NCBI TaxId: 170814
/// </summary>
public abstract class Centroscymnus : Somniosidae, ICentroscymnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centroscymnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170814;

    /// <inheritdoc />
    public virtual string GenusName => "Centroscymnus";

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
