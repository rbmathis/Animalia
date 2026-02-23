using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Empidonomus;

/// <summary>
/// Abstract class for Empidonomus (genus).
/// NCBI TaxId: 478626
/// </summary>
public abstract class Empidonomus : Tyrannidae, IEmpidonomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Empidonomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 478626;

    /// <inheritdoc />
    public virtual string GenusName => "Empidonomus";

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
