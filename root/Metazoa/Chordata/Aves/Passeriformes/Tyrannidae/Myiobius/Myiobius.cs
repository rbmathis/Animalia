using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiobius;

/// <summary>
/// Abstract class for Myiobius (genus).
/// NCBI TaxId: 190022
/// </summary>
public abstract class Myiobius : Tyrannidae, IMyiobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myiobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190022;

    /// <inheritdoc />
    public virtual string GenusName => "Myiobius";

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
