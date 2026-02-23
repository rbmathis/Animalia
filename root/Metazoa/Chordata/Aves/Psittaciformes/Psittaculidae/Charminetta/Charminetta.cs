using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Charminetta;

/// <summary>
/// Abstract class for Charminetta (genus).
/// NCBI TaxId: 3150816
/// </summary>
public abstract class Charminetta : Psittaculidae, ICharminetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Charminetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150816;

    /// <inheritdoc />
    public virtual string GenusName => "Charminetta";

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
