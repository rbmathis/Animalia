using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Pelecanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Pelecanidae.Pelecanus;

/// <summary>
/// Abstract class for Pelecanus (genus).
/// NCBI TaxId: 33617
/// </summary>
public abstract class Pelecanus : Pelecanidae, IPelecanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelecanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33617;

    /// <inheritdoc />
    public virtual string GenusName => "Pelecanus";

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
