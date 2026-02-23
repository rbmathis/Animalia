using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Trichoglossus;

/// <summary>
/// Abstract class for Trichoglossus (genus).
/// NCBI TaxId: 176048
/// </summary>
public abstract class Trichoglossus : Psittaculidae, ITrichoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176048;

    /// <inheritdoc />
    public virtual string GenusName => "Trichoglossus";

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
