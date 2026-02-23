using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Pseudonestor;

/// <summary>
/// Abstract class for Pseudonestor (genus).
/// NCBI TaxId: 64812
/// </summary>
public abstract class Pseudonestor : Fringillidae, IPseudonestor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudonestor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64812;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudonestor";

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
