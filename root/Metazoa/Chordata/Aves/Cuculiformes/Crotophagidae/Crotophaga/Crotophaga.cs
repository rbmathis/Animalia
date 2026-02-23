using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Crotophagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Crotophagidae.Crotophaga;

/// <summary>
/// Abstract class for Crotophaga (genus).
/// NCBI TaxId: 33597
/// </summary>
public abstract class Crotophaga : Crotophagidae, ICrotophaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crotophaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33597;

    /// <inheritdoc />
    public virtual string GenusName => "Crotophaga";

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
