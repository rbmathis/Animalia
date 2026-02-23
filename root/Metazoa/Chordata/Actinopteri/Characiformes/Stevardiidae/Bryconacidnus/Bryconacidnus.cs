using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Bryconacidnus;

/// <summary>
/// Abstract class for Bryconacidnus (genus).
/// NCBI TaxId: 1463299
/// </summary>
public abstract class Bryconacidnus : Stevardiidae, IBryconacidnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bryconacidnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1463299;

    /// <inheritdoc />
    public virtual string GenusName => "Bryconacidnus";

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
