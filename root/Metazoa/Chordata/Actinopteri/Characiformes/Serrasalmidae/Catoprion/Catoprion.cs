using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Catoprion;

/// <summary>
/// Abstract class for Catoprion (genus).
/// NCBI TaxId: 42537
/// </summary>
public abstract class Catoprion : Serrasalmidae, ICatoprion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Catoprion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42537;

    /// <inheritdoc />
    public virtual string GenusName => "Catoprion";

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
