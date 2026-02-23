using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Odontostoechus;

/// <summary>
/// Abstract class for Odontostoechus (genus).
/// NCBI TaxId: 681925
/// </summary>
public abstract class Odontostoechus : Stevardiidae, IOdontostoechus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontostoechus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681925;

    /// <inheritdoc />
    public virtual string GenusName => "Odontostoechus";

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
