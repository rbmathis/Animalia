using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Oriturus;

/// <summary>
/// Abstract class for Oriturus (genus).
/// NCBI TaxId: 380370
/// </summary>
public abstract class Oriturus : Passerellidae, IOriturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oriturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 380370;

    /// <inheritdoc />
    public virtual string GenusName => "Oriturus";

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
