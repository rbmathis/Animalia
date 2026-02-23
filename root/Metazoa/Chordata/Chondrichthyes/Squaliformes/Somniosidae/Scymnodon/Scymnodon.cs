using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae.Scymnodon;

/// <summary>
/// Abstract class for Scymnodon (genus).
/// NCBI TaxId: 862901
/// </summary>
public abstract class Scymnodon : Somniosidae, IScymnodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scymnodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 862901;

    /// <inheritdoc />
    public virtual string GenusName => "Scymnodon";

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
