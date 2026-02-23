using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae.Proscymnodon;

/// <summary>
/// Abstract class for Proscymnodon (genus).
/// NCBI TaxId: 556023
/// </summary>
public abstract class Proscymnodon : Somniosidae, IProscymnodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proscymnodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 556023;

    /// <inheritdoc />
    public virtual string GenusName => "Proscymnodon";

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
