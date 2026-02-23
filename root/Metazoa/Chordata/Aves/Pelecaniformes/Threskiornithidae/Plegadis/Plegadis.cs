using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Plegadis;

/// <summary>
/// Abstract class for Plegadis (genus).
/// NCBI TaxId: 33575
/// </summary>
public abstract class Plegadis : Threskiornithidae, IPlegadis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plegadis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33575;

    /// <inheritdoc />
    public virtual string GenusName => "Plegadis";

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
