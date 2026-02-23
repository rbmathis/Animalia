using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Campephaga;

/// <summary>
/// Abstract class for Campephaga (genus).
/// NCBI TaxId: 137516
/// </summary>
public abstract class Campephaga : Campephagidae, ICampephaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Campephaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137516;

    /// <inheritdoc />
    public virtual string GenusName => "Campephaga";

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
